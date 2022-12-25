﻿using OpenAI.Net.Models.OperationResult;
using OpenAI.Net.Models.Requests;
using OpenAI.Net.Models.Responses.Common;
using OpenAI.Net.Models.Responses;
using OpenAI.Net.Extensions;
using OpenAI.Net.Services.Interfaces;

namespace OpenAI.Net.Services
{
    public class EmbeddingsService : BaseService, IEmbeddingsService
    {
        public EmbeddingsService(HttpClient client) : base(client)
        {
        }

        public Task<OpenAIHttpOperationResult<EmbeddingsResponse, ErrorResponse>> Create(EmbeddingsRequest model)
        {
            return HttpClient.Post<EmbeddingsResponse, ErrorResponse>($"v1/embeddings", model, JsonSerializerOptions);
        }

    }
}