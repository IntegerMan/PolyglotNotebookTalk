using Microsoft.ML;
using Microsoft.ML.AutoML;
using Microsoft.ML.Data;

using System.Collections.Generic;

    /// <summary>
    /// This class represents a single unreleased video game
    /// </summary>    
    public class GameInfo
    {
        [LoadColumn(0)]
        public string Title { get; set; }

        // These columns are our Features that impact the ESRB label
        [LoadColumn(1)]
        public bool Console { get; set; }
        [LoadColumn(2)]
        public bool AlcoholReference { get; set; }
        [LoadColumn(3)]
        public bool AnimatedBlood { get; set; }
        [LoadColumn(4)]
        public bool Blood { get; set; }
        [LoadColumn(5)]
        public bool BloodAndGore { get; set; }
        [LoadColumn(6)]
        public bool CartoonViolence { get; set; }
        [LoadColumn(7)]
        public bool CrudeHumor { get; set; }
        [LoadColumn(8)]
        public bool DrugReference { get; set; }
        [LoadColumn(9)]
        public bool FantasyViolence { get; set; }
        [LoadColumn(10)]
        public bool IntenseViolence { get; set; }
        [LoadColumn(11)]
        public bool Language { get; set; }
        [LoadColumn(12)]
        public bool Lyrics { get; set; }
        [LoadColumn(13)]
        public bool MatureHumor { get; set; }
        [LoadColumn(14)]
        public bool MildBlood { get; set; }
        [LoadColumn(15)]
        public bool MildCartoonViolence { get; set; }
        [LoadColumn(16)]
        public bool MildFantasyViolence { get; set; }
        [LoadColumn(17)]
        public bool MildLanguage { get; set; }
        [LoadColumn(18)]
        public bool MildLyrics { get; set; }
        [LoadColumn(19)]
        public bool MildSuggestiveThemes { get; set; }
        [LoadColumn(20)]
        public bool MildViolence { get; set; }
        [LoadColumn(21)]
        public bool NoDescriptors { get; set; }
        [LoadColumn(22)]
        public bool Nudity { get; set; }
        [LoadColumn(23)]
        public bool PartialNudity { get; set; }
        [LoadColumn(24)]
        public bool SexualContent { get; set; }
        [LoadColumn(25)]
        public bool SexualThemes { get; set; }
        [LoadColumn(26)]
        public bool SimulatedGambling { get; set; }
        [LoadColumn(27)]
        public bool StrongLanguage { get; set; }
        [LoadColumn(28)]
        public bool StrongSexualContent { get; set; }
        [LoadColumn(29)]
        public bool SuggestiveThemes { get; set; }
        [LoadColumn(30)]
        public bool UseOfAlcohol { get; set; }
        [LoadColumn(31)]
        public bool UseOfDrugsAndAlcohol { get; set; }
        [LoadColumn(32)]
        public bool Violence { get; set; }

        // This is our Label column - the one we're trying to predict
        [LoadColumn(33)]
        public string ESRBRating { get; set; }

        public override string ToString() => "{" + Title + "}";
    }

    /// <summary>
    /// This class can report the progress of a machine learning job in progress
    /// </summary>
    public class MulticlassConsoleProgressReporter 
        : IProgress<RunDetail<MulticlassClassificationMetrics>>
    {
        public void Report(RunDetail<MulticlassClassificationMetrics> value)
        {
            if (value.ValidationMetrics != null)
            {
                double accuracy = value.ValidationMetrics.MacroAccuracy;

                Console.WriteLine($"{value.TrainerName} ran in {value.RuntimeInSeconds:0.00} seconds with accuracy of {accuracy:p}");
            }
            else
            {
                Console.WriteLine($"{value.TrainerName} ran in {value.RuntimeInSeconds:0.00} seconds but did not complete. Time likely expired.");
            }
        }
    }