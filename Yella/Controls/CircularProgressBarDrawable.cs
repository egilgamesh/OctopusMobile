﻿namespace Yella.Controls;

public class CircularProgressBarDrawable : BindableObject, IDrawable
{
	public static readonly BindableProperty ProgressProperty =
		BindableProperty.Create(nameof(Progress), typeof(int),
			typeof(CircularProgressBarDrawable));
	public static readonly BindableProperty SizeProperty =
		BindableProperty.Create(nameof(Size), typeof(int), typeof(CircularProgressBarDrawable));
	public static readonly BindableProperty ThicknessProperty =
		BindableProperty.Create(nameof(Thickness), typeof(int),
			typeof(CircularProgressBarDrawable));
	public static readonly BindableProperty ProgressColorProperty =
		BindableProperty.Create(nameof(ProgressColor), typeof(Color),
			typeof(CircularProgressBarDrawable));
	public static readonly BindableProperty ProgressLeftColorProperty =
		BindableProperty.Create(nameof(ProgressLeftColor), typeof(Color),
			typeof(CircularProgressBarDrawable));
	public static readonly BindableProperty TextColorProperty =
		BindableProperty.Create(nameof(TextColor), typeof(Color),
			typeof(CircularProgressBarDrawable));
	public int Progress
	{
		get => (int)GetValue(ProgressProperty)!;
		set => SetValue(ProgressProperty, value);
	}
	public int Size
	{
		get => (int)GetValue(SizeProperty)!;
		set => SetValue(SizeProperty, value);
	}
	public int Thickness
	{
		get => (int)GetValue(ThicknessProperty)!;
		set => SetValue(ThicknessProperty, value);
	}
	public Color ProgressColor
	{
		get => (Color)GetValue(ProgressColorProperty);
		set => SetValue(ProgressColorProperty, value);
	}
	public Color ProgressLeftColor
	{
		get => (Color)GetValue(ProgressLeftColorProperty);
		set => SetValue(ProgressLeftColorProperty, value);
	}
	public Color TextColor
	{
		get => (Color)GetValue(TextColorProperty);
		set => SetValue(TextColorProperty, value);
	}

	// ReSharper disable once MethodTooLong
	public void Draw(ICanvas canvas, RectF dirtyRect)
	{
		var effectiveSize = Size - Thickness;
		var x = Thickness / 2;
		var y = Thickness / 2;
		Progress = Progress switch
		{
			< 0 => 0,
			> 100 => 100,
			_ => Progress
		};
		if (Progress < 100)
		{
			var angle = GetAngle(Progress);
			canvas!.StrokeColor = ProgressLeftColor;
			canvas.StrokeSize = Thickness;
			canvas.DrawEllipse(x, y, effectiveSize, effectiveSize);

			// Draw arc
			canvas.StrokeColor = ProgressColor;
			canvas.StrokeSize = Thickness;
			canvas.DrawArc(x, y, effectiveSize, effectiveSize, 90, angle, true, false);
		}
		else
		{
			// Draw circle
			canvas!.StrokeColor = ProgressColor;
			canvas.StrokeSize = Thickness;
			canvas.DrawEllipse(x, y, effectiveSize, effectiveSize);
		}

		// Make the percentage always the same size in relation to the size of the progress bar
		var fontSize = effectiveSize / 2.86f;
		canvas.FontSize = fontSize;
		canvas.FontColor = TextColor;

		// Vertical text align the text, and we need a correction factor of around 1.15 to have it aligned properly
		// Note: The VerticalAlignment.Center property of the DrawString method seems to have no effect
		var verticalPosition = ((float)Size / 2 - fontSize / 2) * 1.15f;
		canvas.DrawString($"{Progress}", x, verticalPosition, effectiveSize, (float)effectiveSize / 4,
			HorizontalAlignment.Center, VerticalAlignment.Center);
	}

	private static float GetAngle(int progress)
	{
		const float Factor = 90f / 25f;
		switch (progress)
		{
		case > 75:
			return -180 - (progress - 75) * Factor;
		case > 50:
			return -90 - (progress - 50) * Factor;
		case > 25:
			return 0 - (progress - 25) * Factor;
		default:
			return 90 - progress * Factor;
		}
	}
}