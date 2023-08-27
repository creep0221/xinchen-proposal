using System.ComponentModel;

namespace xinchen_web.Enumerables
{
    public enum ProposalStatus
    {
        [Description("企劃中")]
        Planning = 1,
        [Description("提案中")]
        Proposal = 2,
        [Description("執行中")]
        Executing = 3,
        [Description("已結案")]
        Finished = 4

    }
}
