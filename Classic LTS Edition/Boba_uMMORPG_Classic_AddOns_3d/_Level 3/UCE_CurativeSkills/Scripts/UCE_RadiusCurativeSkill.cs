// =======================================================================================
// Maintained by bobatea#9400 on Discord
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............:  
  
// * Leave a star on my Github Repo.....: https://github.com/breehuynh/Bree-mmorpg-tools
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
using System.Collections.Generic;
using UnityEngine;

// RADIUS CURATIVE SKILL

[CreateAssetMenu(menuName = "UCE Skills/UCE Radius Curative Skill", order = 999)]
public class UCE_RadiusCurativeSkill : UCE_CurativeSkill
{
    // -----------------------------------------------------------------------------------
    // CheckTarget
    // -----------------------------------------------------------------------------------
    public override bool CheckTarget(Entity caster)
    {
        return true;
    }

    // -----------------------------------------------------------------------------------
    // CheckDistance
    // -----------------------------------------------------------------------------------
    public override bool CheckDistance(Entity caster, int skillLevel, out Vector3 destination)
    {
        destination = caster.transform.position;
        return true;
    }

    // -----------------------------------------------------------------------------------
    // Apply
    // -----------------------------------------------------------------------------------
    public override void Apply(Entity caster, int skillLevel)
    {
        List<Entity> targets = new List<Entity>();

        if (affectSelf)
            targets.Add(caster);

        if (caster is Player)
            targets.AddRange(((Player)caster).UCE_GetCorrectedTargetsInSphere(caster.transform, castRadius.Get(skillLevel), reviveChance.Get(skillLevel) > 0, affectSelf, affectOwnParty, affectOwnGuild, affectOwnRealm, reverseTargeting, affectPlayers, affectEnemies));
        else
            targets.AddRange(caster.UCE_GetCorrectedTargetsInSphere(caster.transform, castRadius.Get(skillLevel), reviveChance.Get(skillLevel) > 0, affectSelf, affectOwnParty, affectOwnGuild, affectOwnRealm, reverseTargeting, affectPlayers, affectEnemies));

        ApplyToTargets(targets, caster, skillLevel);

        targets.Clear();
    }

    // -----------------------------------------------------------------------------------
}
