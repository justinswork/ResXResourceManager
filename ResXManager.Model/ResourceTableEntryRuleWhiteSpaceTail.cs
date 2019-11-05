﻿namespace tomenglertde.ResXManager.Model
{
    using System.Collections.Generic;
    using System.Linq;

    using tomenglertde.ResXManager.Model.Properties;
    
    [LocalizedDisplayName(StringResourceKey.ResourceTableEntryRuleWhiteSpaceTail_Name)]
    [LocalizedDescription(StringResourceKey.ResourceTableEntryRuleWhiteSpaceTail_Description)]
    internal sealed class ResourceTableEntryRuleWhiteSpaceTail : ResourceTableEntryRuleWhiteSpace
    {
        internal const string WhiteSpaceTail = "whiteSpaceTail";

        public override string RuleId => WhiteSpaceTail;

        protected override IEnumerable<char> GetCharIterator(string value) => value.Reverse();

        protected override string GetErrorMessage(IEnumerable<string> reference)
        {
            var whiteSpaceSeq = string.Join("][", reference.Reverse());

            var intro = Resources.ResourceTableEntryRuleWhiteSpaceTail_Error_Intro;
            if (string.IsNullOrEmpty(whiteSpaceSeq))
                return intro + " " + Resources.ResourceTableEntryRuleWhiteSpaceTail_Error_NoWhiteSpaceExpected;

            whiteSpaceSeq = "[" + whiteSpaceSeq + "]";
            return intro + " " + string.Format(Resources.Culture,
                Resources.ResourceTableEntryRuleWhiteSpaceTail_Error_WhiteSpaceSeqExpected,
                whiteSpaceSeq);
        }
    }
}