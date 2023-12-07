using Microsoft.EntityFrameworkCore;
using Youshow.Ace.Domain.Models;

namespace dotnet.Domain.PaymentInfo;

public class singlePayment : BaseModel<int>
{
    [Comment("支出")]
    public decimal Amount { get; set; } 

    [Comment("开支内容")]
    public string remark{get;set;}

    [Comment("开支时间")]
    public DateTime theTime{get;set;}

    [Comment("这顿是否是饭")]
    public bool isMeal{get;set;}

    [Comment("此顿饭热量是多少")]
    public int calories{get;set;}


}
