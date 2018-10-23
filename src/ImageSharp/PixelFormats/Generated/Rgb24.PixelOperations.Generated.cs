﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

// <auto-generated />
namespace SixLabors.ImageSharp.PixelFormats
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    /// <content>
    /// Provides optimized overrides for bulk operations.
    /// </content>
    public partial struct Rgb24
    {

        /// <summary>
        /// Provides optimized overrides for bulk operations.
        /// </summary>
        internal class PixelOperations : PixelOperations<Rgb24>
        {
            /// <inheritdoc />
            internal override void PackFromRgb24(ReadOnlySpan<Rgb24> source, Span<Rgb24> destPixels, int count)
            {
                GuardSpans(source, nameof(source), destPixels, nameof(destPixels), count);

                source.Slice(0, count).CopyTo(destPixels);
            }

            /// <inheritdoc />
            internal override void ToRgb24(ReadOnlySpan<Rgb24> sourcePixels, Span<Rgb24> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                sourcePixels.Slice(0, count).CopyTo(destPixels);
            }

			
			/// <inheritdoc />
            internal override void ToArgb32(ReadOnlySpan<Rgb24> sourcePixels, Span<Argb32> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Rgb24 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Argb32 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Rgb24 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Argb32 dp = ref Unsafe.Add(ref destRef, i);

                    dp.PackFromRgb24(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToBgr24(ReadOnlySpan<Rgb24> sourcePixels, Span<Bgr24> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Rgb24 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Bgr24 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Rgb24 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Bgr24 dp = ref Unsafe.Add(ref destRef, i);

                    dp.PackFromRgb24(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToBgra32(ReadOnlySpan<Rgb24> sourcePixels, Span<Bgra32> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Rgb24 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Bgra32 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Rgb24 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Bgra32 dp = ref Unsafe.Add(ref destRef, i);

                    dp.PackFromRgb24(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToGray8(ReadOnlySpan<Rgb24> sourcePixels, Span<Gray8> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Rgb24 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Gray8 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Rgb24 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Gray8 dp = ref Unsafe.Add(ref destRef, i);

                    dp.PackFromRgb24(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToGray16(ReadOnlySpan<Rgb24> sourcePixels, Span<Gray16> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Rgb24 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Gray16 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Rgb24 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Gray16 dp = ref Unsafe.Add(ref destRef, i);

                    dp.PackFromRgb24(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToRgba32(ReadOnlySpan<Rgb24> sourcePixels, Span<Rgba32> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Rgb24 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Rgba32 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Rgb24 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgba32 dp = ref Unsafe.Add(ref destRef, i);

                    dp.PackFromRgb24(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToRgb48(ReadOnlySpan<Rgb24> sourcePixels, Span<Rgb48> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Rgb24 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Rgb48 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Rgb24 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgb48 dp = ref Unsafe.Add(ref destRef, i);

                    dp.PackFromRgb24(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToRgba64(ReadOnlySpan<Rgb24> sourcePixels, Span<Rgba64> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Rgb24 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Rgba64 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Rgb24 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgba64 dp = ref Unsafe.Add(ref destRef, i);

                    dp.PackFromRgb24(sp);
                }
            }
		
		}
	}
}