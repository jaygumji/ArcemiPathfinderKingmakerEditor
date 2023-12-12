﻿#region License
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */
#endregion
using Newtonsoft.Json.Linq;
using System;

namespace Arcemi.Models
{
    public interface IReferences
    {
        bool TryGetReferred(string refId, out JObject refObj);
        JObject GetReferred(JObject obj);
        void BubbleRemoval(JToken token);
        JObject Create();
        JObject CreateReference(JToken parent, string refId);
        JObject CreateReference(JToken parent, JObject refObj);
        JArray NewArray(int size, JToken initialValue);
        JArray NewArray(int size, Func<JToken> initialValue);

        T GetOrCreateObject<T>(JObject obj, Func<ModelDataAccessor, T> factory = null);
        T GetOrCreateObject<T>(JObject parent, string name, Func<ModelDataAccessor, T> factory = null, bool createIfNull = false);
        ListAccessor<T> GetOrCreateList<T>(JObject parent, string name, Func<ModelDataAccessor, T> factory = null, bool createIfNull = false)
            where T : Model;
        ListValueAccessor<T> GetOrCreateListValue<T>(JObject parent, string name, bool createIfNull = false);
        ListD2Accessor<T> GetOrCreateListD2<T>(JObject parent, string name, Func<ModelDataAccessor, T> factory = null, bool createIfNull = false)
            where T : Model;
        DictionaryOfValueAccessor<TValue> GetOrCreateDictionaryOfValue<TValue>(JObject parent, string name, bool createIfNull = false);
        DictionaryAccessor<T> GetOrCreateDictionary<T>(JObject parent, string name, Func<ModelDataAccessor, T> factory = null, bool createIfNull = false)
            where T : Model;
        DictionaryOfValueListAccessor<TValue> GetOrCreateDictionaryOfValueList<TValue>(JObject parent, string name, bool createIfNull = false);

        bool RemoveObject(JObject parent, string name);
        bool RemoveList(JObject parent, string name);
        bool RemoveListValue(JObject parent, string name);
        void Refresh(JObject parent);
    }
}