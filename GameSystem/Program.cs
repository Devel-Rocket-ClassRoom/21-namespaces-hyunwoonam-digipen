using System;

// README.md를 읽고 아래에 코드를 작성하세요.
using MyGame.Characters;
using MyGame.Items;

Console.WriteLine("=== 캐릭터 시스템 ===");
Player player = new Player { Name = "용사" };
Enemy enemy = new Enemy { Type = "고블린" };

player.Attack();
enemy.TakeDamage();

Console.WriteLine();

Console.WriteLine("=== 아이템 시스템 ===");

Weapon weapon = new Weapon { Name = "불꽃검", Damage = 50 };
Potion potion = new Potion { Name = "체력 포션" };

weapon.GetDamage();
potion.Use();