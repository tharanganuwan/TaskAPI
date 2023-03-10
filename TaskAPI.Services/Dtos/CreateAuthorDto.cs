using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Services.Dtos
{
    public class CreateAuthorDto
    {
        public string Fullname { get; set; }

        public string AddressNo { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string JobRole { get; set; }
    }
}
