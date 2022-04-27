﻿using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace ViewModelsSamples.StackedBars.Basic;

public class ViewModel
{
    public List<ISeries> Series { get; set; } = new()
    {
        new StackedColumnSeries<int>
        {
            Values = new List<int> { 3, 5, 3, 2, 5, 4, 2 },
            Stroke = null,
            DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
            DataLabelsSize = 14,
            DataLabelsPosition = DataLabelsPosition.Middle
        },
        new StackedColumnSeries<int>
        {
            Values = new List<int> { 4, 2, 3, 2, 3, 4, 2 },
            Stroke = null,
            DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
            DataLabelsSize = 14,
            DataLabelsPosition = DataLabelsPosition.Middle
        },
        new StackedColumnSeries<int>
        {
            Values = new List<int> { 2, 6, 6, 5, 4, 3, 2 },
            Stroke = null,
            DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
            DataLabelsSize = 14,
            DataLabelsPosition = DataLabelsPosition.Middle
        }
    };
}
