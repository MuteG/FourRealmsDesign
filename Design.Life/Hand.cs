/* *************************************************************************
 * Copyright (c)2012 NTT DATA BEEN (China) Information Technology Co.,Ltd.
 * 作成者  ：gaoyunpeng
 * 機能概要：
 * 改訂履歴：
 * 2012/9/26 11:26:50 新規 gaoyunpeng
 * *************************************************************************/
namespace FourRealms.Design.Life
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FourRealms.Design.Item;

    public class Hand
    {
        /// <summary>
        /// 手中拿着的物品
        /// </summary>
        public AbstractItem Item { get; set; }

        public HandPosition Position { get; set; }

        public void Hold(AbstractItem item)
        {
            this.Item = item;
        }
    }
}
