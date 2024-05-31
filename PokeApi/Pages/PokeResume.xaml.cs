using PokeApi.Models;
using PokeApi.Service;

namespace PokeApi.Pages;

public partial class PokeResume : ContentPage
{
    PokeCharact pokeCharact = new PokeCharact();
    EffectInfo effectInfo = new EffectInfo();
    public PokeResume(string url)
    {
        InitializeComponent();
        LoadPokeResume(url);
        LoadPokeAbilitiesInfo(url);
    }

    public async void LoadPokeResume(string url)
    {
        PokeService poke = new PokeService();
        pokeCharact = await poke.PokeCharacteristics(url);
        PokeImage.Source = pokeCharact.sprites.front_default;

        string abilities = "| ";
        foreach (var ability in pokeCharact.abilities)
        {
            abilities += ability.ability.name + " | ";
        }

        Abilitiess.Text = abilities;
    }

    public async void LoadPokeAbilitiesInfo(string url)
    {
        PokeService pokes = new PokeService();
        effectInfo = await pokes.PokeAbilitiesInfo(url);

        if (effectInfo.effect_entries != null && effectInfo.effect_entries.Count > 0)
        {
            var firstEffectEntry = effectInfo.effect_entries.FirstOrDefault();
            effectP.Text = firstEffectEntry.effect;
            shortEffectP.Text = firstEffectEntry.short_effect;
        }
        else
        {
            effectP.Text = "Sin efectos que mostrar";
            shortEffectP.Text = "Sin efectos cortos que mostrar";
        }
    }

}