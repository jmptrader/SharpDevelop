﻿// Copyright (c) https://github.com/ddur
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;

namespace ICSharpCode.CodeCoverage
{
	/// <summary>
	/// Description of CodeCoverageBranchPoint.
	/// </summary>
	public class CodeCoverageBranchPoint
	{
		public int VisitCount { get; set; }
		public int Path { get; set; }
		public int Offset { get; set; }
		public int OffsetEnd { get; set; }
	}

}
