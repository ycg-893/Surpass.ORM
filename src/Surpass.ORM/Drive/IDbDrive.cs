using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surpass.ORM.Drive
{
    /// <summary>
    /// 数据驱动抽象
    /// </summary>
    public interface IDbDrive
    {
        /// <summary>
        /// 获取提供程序名称
        /// </summary>
        string ProviderName { get; }


    }
}
