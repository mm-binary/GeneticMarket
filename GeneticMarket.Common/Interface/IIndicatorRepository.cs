﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticMarket.Common.Interface
{
    public interface IIndicatorRepository
    {
        IIndicator AddIndicator(IIndicator indicator);
    }
}
