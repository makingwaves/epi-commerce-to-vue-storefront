﻿using System.Threading.Tasks;
using EPiServer.Vsf.Core.ApiBridge.Model.Stock;

namespace EPiServer.Vsf.Core.ApiBridge.Adapter
{
    public interface IStockAdapter
    {
        Task<VsfStockCheck> Check(string code);
    }
}