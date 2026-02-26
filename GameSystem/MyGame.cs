using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Characters
{
    public class Player
    {
        public string Name;

        public void Attack()
        {
            Console.WriteLine($"플레이어 {Name}(이)가 공격합니다!");
        }
    }

    public class Enemy
    {
        public string Type;

        public void TakeDamage()
        {
            Console.WriteLine($"적 {Type}(이)가 데미지를 받았습니다!");
        }
    }
}

namespace MyGame.Items
{
    public class Weapon
    {
        public string Name;
        public int Damage;

        public void GetDamage()
        {
            Console.WriteLine($"무기 {Name}의 공격력: {Damage}");
        }
    }

    public class Potion
    {
        public string Name;

        public void Use()
        {
            Console.WriteLine($"포션 {Name} 포션을(를) 사용했습니다.");
        }
    }
}