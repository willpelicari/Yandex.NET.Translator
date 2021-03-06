﻿namespace Yandex.Translator
{
  using RestSharp;
  using RestSharp.Deserializers;

  internal sealed class YandexTranslatorJsonDeserializer : IDeserializer
  {
    public T Deserialize<T>(IRestResponse response)
    {
      return response.Content.Json<T>();
    }

    public string RootElement { get; set; }

    public string Namespace { get; set; }

    public string DateFormat { get; set; }
  }
}