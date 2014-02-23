﻿using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public struct LinesAndCount {
        public int count;
        public string[] lines;
    }
    public class AdminController : ApiController
    {
        static readonly VacancyRepository repo = VacancyRepository.repo;

        public LinesAndCount Get()
        {
            return repo.UpdateSearchTerms();
        }
    }
}
