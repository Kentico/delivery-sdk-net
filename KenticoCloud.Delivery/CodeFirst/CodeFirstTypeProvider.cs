﻿using System;

namespace KenticoCloud.Delivery.CodeFirst
{
    internal class CodeFirstTypeProvider : ICodeFirstTypeProvider
    {
        public Type GetType(string contentType)
            => null;

        public string GetCodename(Type contentType)
            => null;
    }
}