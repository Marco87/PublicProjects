import pandas as pd

# Dados de Cristiano Ronaldo (2009-2018)
cristiano_ronaldo_data = {
    'Jogador': ['Cristiano Ronaldo'] * 9,
    'Temporada': ['2009-2010', '2010-2011', '2011-2012', '2012-2013', '2013-2014', '2014-2015', '2015-2016', '2016-2017', '2017-2018'],
    'Jogos': [29, 34, 55, 55, 47, 54, 48, 46, 44],
    'Gols': [33, 53, 60, 55, 51, 61, 51, 42, 44]}

# Dados de Lionel Messi (2009-2018)
lionel_messi_data = {
    'Jogador': ['Lionel Messi'] * 9,
    'Temporada': ['2009-2010', '2010-2011', '2011-2012', '2012-2013', '2013-2014', '2014-2015', '2015-2016', '2016-2017', '2017-2018'],
    'Jogos': [53, 55, 69, 50, 46, 57, 49, 52, 54],
    'Gols': [47, 53, 73, 60, 41, 58, 41, 54, 45]
}

# Criando dataframes
df_cristiano = pd.DataFrame(cristiano_ronaldo_data)
df_messi = pd.DataFrame(lionel_messi_data)

# Concatenando os dataframes
df = pd.concat([df_cristiano, df_messi], ignore_index=True)

# Exibindo o dataframe
print(df)

# Salvar o DataFrame em um arquivo CSV
df.to_csv('dados_jogadores.csv', index=False)
