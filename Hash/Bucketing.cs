using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class Bucketing: HasHTable
    {
        //=============================================
        private static readonly int DEFAULT_INITIAL_CAPACITY = 1024;
        private static readonly int MAXIMUM_CAPACITY = 1 << 30;
        private static readonly string delete = "";
        private int tablesize;
        private int size;
        private string[] table;
        private int[] position;
        private string[] overFlowtable;
        private int numofCollisions;
        private int numofBucket;
        private int bucketSize;
        private int freePlace;


    }
}
