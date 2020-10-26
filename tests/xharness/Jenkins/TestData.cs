﻿using System.Collections.Generic;
using Microsoft.DotNet.XHarness.iOS.Shared;
using Microsoft.DotNet.XHarness.iOS.Shared.Hardware;

namespace Xharness.Jenkins {

	class TestData
	{
		public string Variation;
		public string MTouchExtraArgs;
		public string MonoBundlingExtraArgs; // mmp
		public (string HumanMessage, string IssueLink)? KnownFailure;
		public bool Debug;
		public bool Profiling;
		public string LinkMode;
		public string Defines;
		public string Undefines;
		public bool? Ignored;
		public bool EnableSGenConc;
		public bool UseThumb;
		public MonoNativeLinkMode MonoNativeLinkMode;
		public IEnumerable<IDevice> Candidates;
	}
}
