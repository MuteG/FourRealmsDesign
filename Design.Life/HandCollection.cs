/* *************************************************************************
 * Copyright (c)2012 NTT DATA BEEN (China) Information Technology Co.,Ltd.
 * 作成者  ：gaoyunpeng
 * 機能概要：
 * 改訂履歴：
 * 2012/9/26 11:27:56 新規 gaoyunpeng
 * *************************************************************************/
namespace FourRealms.Design.Life
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections.ObjectModel;

    public class HandCollection : Collection<Hand>
    {
        public void Remove(HandPosition position)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Position == position)
                {
                    RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
