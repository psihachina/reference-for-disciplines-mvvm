﻿using System;

namespace ReferenceForDisciplines.Annotations
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class HtmlAttributeValueAttribute : Attribute
    {
        public HtmlAttributeValueAttribute([NotNull] string name)
        {
            Name = name;
        }

        [NotNull] public string Name { get; }
    }
}