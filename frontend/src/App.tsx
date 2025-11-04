import { useEffect, useState } from 'react'
import flapoLogo from '/favicon.png'
import './App.css'
import { AppBar, Box, Button, Stack, Toolbar } from '@mui/material'
import FilterAltIcon from '@mui/icons-material/FilterAlt';
import FilterAltOffIcon from '@mui/icons-material/FilterAltOff';
import ArrowDownwardIcon from '@mui/icons-material/ArrowDownward';
import ArrowUpwardIcon from '@mui/icons-material/ArrowUpward';
import type { Article } from './article.types';

const API_URL = 'https://localhost:7092/article'

function App() {
  const [sort, setSort] = useState<string>('');
  const [bottleView, setBottleView] = useState<boolean>(false);
  const [filter, setFilter] = useState<boolean>(false);

  const [articles, setArticles] = useState<Article[]>();

  useEffect(() => {
    const params = new URLSearchParams();
    if (sort !== ''){
      params.append('sortByPrice', sort);
    }
    if (filter){
      params.append('filter', String(filter));
    }

    const fetchArticles = async () => {
      const response = await fetch(`${API_URL}?${params}`);
      const articles = await response.json() as Article[];
      setArticles(articles);
    }
    fetchArticles();
  }, [sort, filter]);

  const toggleView = () => setBottleView(p => !p);
  const toggleFilter = () => setFilter(p => !p);
  const toggleSort = () => setSort(p => {
    if (!p){
      return 'asc';
    } else if (p === 'asc'){
      return 'desc';
    } else {
      return '';
    }
  })

  console.log('articles: ', articles);
  

  return (
    <>
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static">
        <Toolbar>
          <img src={flapoLogo} alt="Vite logo" width="30" height="30" />
          <Stack spacing={2} direction="row">
          <Button color="inherit" onClick={toggleSort}>Sort {sort === 'asc' ? <ArrowUpwardIcon/> : sort === 'desc' ? <ArrowDownwardIcon/> : <></>}</Button>
          <Button color="inherit" onClick={toggleView}>View</Button>
          <Button color="inherit" onClick={toggleFilter}>Filter {filter ? <FilterAltIcon/> : <FilterAltOffIcon />}</Button>
          </Stack>
        </Toolbar>
      </AppBar>
    </Box>
    </>
  )
}

export default App
