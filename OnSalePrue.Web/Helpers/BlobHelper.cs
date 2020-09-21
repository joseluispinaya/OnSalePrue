using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSalePrue.Web.Helpers
{
    public class BlobHelper : IBlobHelper
    {
        //private readonly CloudBlobClient _blobClient;
        public BlobHelper(IConfiguration configuration)
        {

        }

        public Task<Guid> UploadBlobAsync(IFormFile file, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> UploadBlobAsync(byte[] file, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> UploadBlobAsync(string image, string containerName)
        {
            throw new NotImplementedException();
        }
    }
}
