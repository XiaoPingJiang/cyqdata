using System;
using System.Collections.Generic;
using System.Text;

namespace CYQ.Data
{
    /// <summary>
    /// MAction��Insert�����ķ���ֵѡ��
    /// </summary>
    public enum InsertOp
    {
        /// <summary>
        /// ʹ�ô���������ݺ�[MSSQL�᷵��ID,�������ݿ��򲻻᷵��ID]
        /// </summary>
        None,
        /// <summary>
        /// ʹ�ô���������ݺ�᷵��ID��
        /// </summary>
        ID,
        /// <summary>
        /// ʹ�ô���������ݺ�,����ݷ���ID���в�ѯ�����������,[Ĭ��ѡ��]
        /// </summary>
        Fill,
    }

}
