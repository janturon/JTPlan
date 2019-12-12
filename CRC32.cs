using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace JTPlan {
	public class CRC32 { // currently not used
	    const UInt32 generator = 0xEDB88320;
	    readonly UInt32[] table;

	    public CRC32() {
	        table = Enumerable.Range(0, 256).Select(i => {
	            var tableEntry = (uint)i;
	            for(int j=0; j<8; ++j) {
	                tableEntry = ((tableEntry & 1) != 0)
	                    ? (generator ^ (tableEntry >> 1)) 
	                    : (tableEntry >> 1);
	            }
	            return tableEntry;
	        }).ToArray();
	    }
	
	    public UInt32 Get<T>(IEnumerable<T> byteStream) {
	    	return (UInt32)~byteStream.Aggregate(0xFFFFFFFF, (reg, b) =>
	                      (table[(reg & 0xFF) ^ Convert.ToByte(b)] ^ (reg >> 8)));
	    }
	    
	    public UInt32 Get(string file) {
	    	return Get(File.ReadAllBytes(file));
	    }
	}
}
