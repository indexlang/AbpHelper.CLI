﻿using System.Threading;
using System.Threading.Tasks;
using EasyAbp.AbpHelper.Models;
using Elsa.Results;
using Elsa.Services.Models;

namespace EasyAbp.AbpHelper.Steps.Abp
{
    public class SetModelVariableStep : Step
    {
        protected override Task<ActivityExecutionResult> OnExecuteAsync(WorkflowExecutionContext context, CancellationToken cancellationToken)
        {
            var entityInfo = context.GetVariable<EntityInfo>("EntityInfo");
            var projectInfo = context.GetVariable<ProjectInfo>("ProjectInfo");

            context.SetVariable("Model", new {EntityInfo = entityInfo, ProjectInfo = projectInfo});
            return Task.FromResult(Done());
        }
    }
}