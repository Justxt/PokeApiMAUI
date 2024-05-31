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

	public void ShowPokeResume(object sender, SelectedItemChangedEventArgs e)
	{
		PokeInfo pokeInfo = (PokeInfo)e.SelectedItem;
		Navigation.PushAsync(new Pages.PokeResume(pokeInfo.url));
    }

}