// <copyright file="HierarchyTest.cs" company="Microsoft">Copyright � Microsoft 2009</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using Void.Linq;

namespace Void.Linq
{
    /// <summary>This class contains parameterized unit tests for Hierarchy</summary>
    [PexClass(typeof(Hierarchy))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class HierarchyTest
    {
        /// <summary>Test stub for FlattenHierarchy(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,IEnumerable`1&lt;!!0&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<TSource> FlattenHierarchy<TSource>(
            IEnumerable<TSource> source,
            Func<TSource, IEnumerable<TSource>> childrenSelector
        )
        {
            IEnumerable<TSource> result
               = Hierarchy.FlattenHierarchy<TSource>(source, childrenSelector);
            return result;
            // TODO: add assertions to method HierarchyTest.FlattenHierarchy(IEnumerable`1<!!0>, Func`2<!!0,IEnumerable`1<!!0>>)
        }
    }
}