using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace RoleplayGame
{
    public class Items
    {
        public string Name {get;set;}//Nombre del elemento
        public int AttackDamage {get;set;}
        public int Defense {get;set;}

        public string TypeOfItem {get;set;}// Pueden ser ropaje (túnica, por ejemplo), armas (como un hacha o una espada), entre otros.

        public Items(string name,int attackDamage,int defense,string typeOfItem)
        {
            this.Name=name;
            this.AttackDamage=attackDamage;
            this.Defense=defense;
            this.TypeOfItem=typeOfItem;
        }







    }









}