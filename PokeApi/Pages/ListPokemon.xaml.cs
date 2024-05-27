using Newtonsoft.Json;
using PokeApi.Models;
using PokeApi.Service;
using System.Diagnostics;

namespace PokeApi.Pages;

public partial class ListPokemon : ContentPage
{
	public List<PokeInfo> pokeInfos;
	public ListPokemon()
	{

		InitializeComponent();
		LoadPoke();
    }

	public async void LoadPoke()
	{
        PokeService poke = new PokeService();
        pokeInfos = await poke.PokeList();
		pokeInfoss.ItemsSource = pokeInfos;
    }




}