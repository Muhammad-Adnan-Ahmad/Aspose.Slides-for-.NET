﻿Imports System
Imports Aspose.Slides.Charts
Imports Aspose.Slides.Export
Imports Aspose.Slides
Imports Aspose.Slides.Animation

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace VisualBasic.Charts
    Public Class AnimatingCategoriesElements
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Charts()

            Using presentation As New Presentation(dataDir & Convert.ToString("ExistingChart.pptx"))
                ' Get reference of the chart object
                Dim slide = TryCast(presentation.Slides(0), Slide)
                Dim shapes = TryCast(slide.Shapes, ShapeCollection)
                Dim chart = TryCast(shapes(0), IChart)

                ' Animate categories' elements
                slide.Timeline.MainSequence.AddEffect(chart, EffectType.Fade, EffectSubtype.None, EffectTriggerType.AfterPrevious)
                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 0, 0, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)
                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 0, 1, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)
                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 0, 2, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)
                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 0, 3, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)

                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 1, 0, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)
                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 1, 1, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)
                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 1, 2, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)
                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 1, 3, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)

                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 2, 0, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)
                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 2, 1, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)
                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 2, 2, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)
                DirectCast(slide.Timeline.MainSequence, Sequence).AddEffect(chart, EffectChartMinorGroupingType.ByElementInCategory, 2, 3, EffectType.Appear, EffectSubtype.None, _
                    EffectTriggerType.AfterPrevious)

                ' Write the presentation file to disk
                presentation.Save(dataDir & Convert.ToString("AnimatingCategoriesElements.pptx"), SaveFormat.Pptx)
            End Using
        End Sub
    End Class
End Namespace