using System.Collections.Generic;
using UnityEngine;

public class Troll : EnemyBaseClass
{
    public new void Start()
    {
        EnemyName = "Troll";

        // Create Enemy Components & Stats
        EnemyComponents = new Dictionary<string, Dictionary<string, object>>
        {
            { "Head", new Dictionary<string, object>
                {
                    {"maxHP", 30},
                    {"currentHP", 30},
                    {"deadDescription", "Head is disabled"},
                    {"Active", true},
                    {"Dead", false},
                    {"Sprite", "head_sprite.png"},
                    {"DeadSprite", "head_deadsprite.png"},
                }
            },
            { "Body", new Dictionary<string, object>
                {
                    {"maxHP", 30},
                    {"currentHP", 30},
                    {"deadDescription", "Body is disabled"},
                    {"Active", true},
                    {"Dead", false},
                    {"Sprite", "body_sprite.png"},
                    {"DeadSprite", "body_deadsprite.png"},
                }
            },
            { "LeftArm", new Dictionary<string, object>
                {
                    {"maxHP", 20},
                    {"currentHP", 20},
                    {"deadDescription", "Left arm is disabled"},
                    {"Active", true},
                    {"Dead", false},
                    {"Sprite", "leftarm_sprite.png"},
                    {"DeadSprite", "leftarm_deadsprite.png"},
                }
            },
            { "RightArm", new Dictionary<string, object>
                {
                    {"maxHP", 20},
                    {"currentHP", 20},
                    {"deadDescription", "Right arm is disabled"},
                    {"Active", true},
                    {"Dead", false},
                    {"Sprite", "rightarm_sprite.png"},
                    {"DeadSprite", "rightarm_deadsprite.png"},
                }
            },
            { "Legs", new Dictionary<string, object>
                {
                    {"maxHP", 40},
                    {"currentHP", 40},
                    {"deadDescription", "Legs are disabled"},
                    {"Active", true},
                    {"Dead", false},
                    {"Sprite", "legs_sprite.png"},
                    {"DeadSprite", "legs_deadsprite.png"},
                }
            }
        };
    }
}
