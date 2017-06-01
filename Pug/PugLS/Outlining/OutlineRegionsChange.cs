// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.VisualStudio.Pug
{
    internal class OutlineRegionsChange
    {
        public ITextRange ChangedRange { get; private set; }
        public OutlineRegionCollection NewRegions { get; private set; }

        public OutlineRegionsChange(ITextRange changedRange, OutlineRegionCollection newRegions)
        {
            this.ChangedRange = changedRange;
            this.NewRegions = newRegions;
        }
    }
}
