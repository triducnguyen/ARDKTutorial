// Copyright 2021 Niantic, Inc. All Rights Reserved.

using System;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Niantic.ARDK.Recording {
  /// <summary>
  /// Configs for setting point of interest information.
  /// </summary>
  [Obsolete("This will be removed in a future release, use ARCapture classes instead")]
  [StructLayout(LayoutKind.Sequential)]
  public struct ARSetPointOfInterestConfig {
    /// <summary>
    /// The point of interest, represented as a string
    /// </summary>
    [MarshalAs(UnmanagedType.LPStr)] public string PointOfInterest;
  }
}