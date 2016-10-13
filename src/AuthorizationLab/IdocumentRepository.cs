﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationLab
{
    public interface IDocumentRepository
    {

            IEnumerable<Document> Get();

            Document Get(int id);
    }
}
