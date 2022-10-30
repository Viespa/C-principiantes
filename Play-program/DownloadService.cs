using System;
using System.Collections.Generic;
using System.Linq;
using System.text;
using System.Threading.Tasks; 


class DownloadService
{
    public byte[] Download(string songName)
    {   
        Thread.Sleep(1000);
        return new byte[] { };
    }


    public Task<byte[]> DownloadAsync(String songName)
    {
            Thread.Sleep(1000);
            return Task.FromResult(new byte[] { });
    }
}