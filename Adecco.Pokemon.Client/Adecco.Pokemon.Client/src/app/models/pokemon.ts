export interface PokemonPaginated{
    pageSize?: number;
    pageNumber?: number;
    totalCount?: number;
    data?: PokemonViewModel[]
}

export interface PokemonViewModel{
    name?: string; 
}