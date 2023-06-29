using System;
using System.Collections.Generic;

public class Assignment123
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var endpointsOfBestSequences = new List<(int, int)>();

            var currentBuyIndex = 0;

            for (var i = 1; i <= prices.Length; i++)
            {
                var currentPriceOrEndGuard = i < prices.Length
                    ? prices[i]
                    : -1;

                var haveReachedEndOfIncreasingSequence = currentPriceOrEndGuard < prices[i - 1];

                if (!haveReachedEndOfIncreasingSequence)
                {
                    continue;
                }

                var currentSequence = (currentBuyIndex, i - 1);

                var haveNotYetSelectedTwoSequences = endpointsOfBestSequences.Count < 2;

                if (haveNotYetSelectedTwoSequences)
                {
                    endpointsOfBestSequences.Add(currentSequence);

                    currentBuyIndex = i;

                    continue;
                }

                var appliedOption = ChooseAndApplyBestOptionForCombiningSequences(
                    endpointsOfBestSequences,
                    currentSequence,
                    prices
                );

                var shouldStartNewSequenceAfterCurrentOneGotUsed =
                    appliedOption != SequenceCombinationOption.KeepFirstAndSecondExisting;

                if (shouldStartNewSequenceAfterCurrentOneGotUsed)
                {
                    currentBuyIndex = i;

                    continue;
                }

                var shouldDumpCurrentBuyPriceForCurrentPrice = currentPriceOrEndGuard < prices[currentBuyIndex];

                if (shouldDumpCurrentBuyPriceForCurrentPrice)
                {
                    currentBuyIndex = i;
                }
            }

            return SumUpBestSequences(endpointsOfBestSequences, prices);
        }

        private SequenceCombinationOption ChooseAndApplyBestOptionForCombiningSequences(
            List<(int, int)> endpointsOfBestSequences,
            (int, int) currentSequence,
            int[] prices)
        {
            var optionsForCombiningSequences = GetOptionsForCombiningSequences(
                endpointsOfBestSequences,
                currentSequence,
                prices
            );

            Array.Sort(optionsForCombiningSequences, (option1, option2) => option2.Item2 - option1.Item2);

            var bestCombinationOption = optionsForCombiningSequences[0];

            ApplySequenceCombinationOption(
                bestCombinationOption,
                endpointsOfBestSequences,
                currentSequence);

            return bestCombinationOption.Item1;
        }

        private enum SequenceCombinationOption
        {
            KeepFirstAndSecondExisting,
            MergeExistingAndAlsoTakeCurrent,
            KeepFirstAndCurrent,
            KeepSecondAndCurrent,
            KeepFirstAndMergeSecondWithCurrent,
        }

        private (SequenceCombinationOption, int)[] GetOptionsForCombiningSequences(
            List<(int, int)> endpointsOfBestSequences,
            (int, int) currentSequence,
            int[] prices)
        {
            var firstExistingSequence = endpointsOfBestSequences[0];
            var secondExistingSequence = endpointsOfBestSequences[1];

            var firstExistingSequenceProfit = prices[firstExistingSequence.Item2] - prices[firstExistingSequence.Item1];
            var secondExistingSequenceProfit = prices[secondExistingSequence.Item2] - prices[secondExistingSequence.Item1];

            var currentSequenceProfit = prices[currentSequence.Item2] - prices[currentSequence.Item1];

            return new (SequenceCombinationOption, int)[] {
            (SequenceCombinationOption.KeepFirstAndSecondExisting, firstExistingSequenceProfit + secondExistingSequenceProfit),
            (SequenceCombinationOption.MergeExistingAndAlsoTakeCurrent, prices[secondExistingSequence.Item2] - prices[firstExistingSequence.Item1] + currentSequenceProfit),
            (SequenceCombinationOption.KeepFirstAndCurrent, firstExistingSequenceProfit + currentSequenceProfit),
            (SequenceCombinationOption.KeepSecondAndCurrent, secondExistingSequenceProfit + currentSequenceProfit),
            (SequenceCombinationOption.KeepFirstAndMergeSecondWithCurrent,firstExistingSequenceProfit + prices[currentSequence.Item2] - prices[secondExistingSequence.Item1]),
        };
        }

        private void ApplySequenceCombinationOption(
            (SequenceCombinationOption, int) combinationOption,
            List<(int, int)> endpointsOfBestSequences,
            (int, int) currentSequence)
        {
            switch (combinationOption.Item1)
            {
                case SequenceCombinationOption.KeepFirstAndSecondExisting:
                    break;
                case SequenceCombinationOption.MergeExistingAndAlsoTakeCurrent:
                    MergeExistingSequencesAndTakeCurrent(endpointsOfBestSequences, currentSequence);
                    break;
                case SequenceCombinationOption.KeepFirstAndCurrent:
                    endpointsOfBestSequences[1] = currentSequence;
                    break;
                case SequenceCombinationOption.KeepSecondAndCurrent:
                    KeepSecondAndCurrentSequences(endpointsOfBestSequences, currentSequence);
                    break;
                case SequenceCombinationOption.KeepFirstAndMergeSecondWithCurrent:
                    endpointsOfBestSequences[1] = (endpointsOfBestSequences[1].Item1, currentSequence.Item2);
                    break;
            }
        }

        private void MergeExistingSequencesAndTakeCurrent(
            List<(int, int)> endpointsOfBestSequences,
            (int, int) currentSequence)
        {
            var firstExistingSequence = endpointsOfBestSequences[0];
            var secondExistingSequence = endpointsOfBestSequences[1];

            endpointsOfBestSequences.Clear();

            endpointsOfBestSequences.Add((firstExistingSequence.Item1, secondExistingSequence.Item2));

            endpointsOfBestSequences.Add(currentSequence);
        }

        private void KeepSecondAndCurrentSequences(
            List<(int, int)> endpointsOfBestSequences,
            (int, int) currentSequence)
        {
            var secondExistingSequence = endpointsOfBestSequences[1];

            endpointsOfBestSequences.Clear();

            endpointsOfBestSequences.Add(secondExistingSequence);

            endpointsOfBestSequences.Add(currentSequence);
        }

        private int SumUpBestSequences(List<(int, int)> endpointsOfBestSequences, int[] prices)
        {
            var toReturn = 0;

            foreach (var sequence in endpointsOfBestSequences)
            {
                toReturn += prices[sequence.Item2] - prices[sequence.Item1];
            }

            return toReturn;
        }
    }
}
