using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Buffers;

namespace SciSharp.MySQL.Replication
{
    class SetType : IMySQLDataType
    {
        public object ReadValue(ref SequenceReader<byte> reader, int meta)
        {
            return reader.ReadLong(4);
        }
    }
}
