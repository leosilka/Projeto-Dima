using System.ComponentModel.DataAnnotations;

namespace Dima.Core.Control.Enums;

public enum EtransactionType
{
    [Display(Name = "Deposito")]
    Deposit = 1,
    [Display(Name = "Retirada")]
    Withdraw = 2
}
