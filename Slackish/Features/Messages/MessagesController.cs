﻿using MediatR;
using System.Threading.Tasks;
using System.Web.Http;

namespace Slackish.Features.Messages
{
    [RoutePrefix("api/messages")]
    public class MessagesController: ApiController
    {
        public MessagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("send")]
        public async Task<IHttpActionResult> Send(SendMessageCommand.SendMessageRequest request)
            => Ok(await _mediator.SendAsync(request));
        
        private IMediator _mediator;
    }
}