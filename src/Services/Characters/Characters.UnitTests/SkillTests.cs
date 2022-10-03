using Characters.API.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.UnitTests;
public class SkillTests
{
    [Fact]
    public void SkillService_GetSkill_CorrectName()
    {
        var skillService = new SkillService();

        var skill = skillService.GetSkill(-1);

        Assert.Equal("Test Skill", skill.Name);
    }
}
