import { useState } from 'react'
import flapoLogo from '/favicon.png'
import './App.css'
import { AppBar, Box, Button, Stack, Toolbar } from '@mui/material'
import FilterAltIcon from '@mui/icons-material/FilterAlt';
import FilterAltOffIcon from '@mui/icons-material/FilterAltOff';
import ArrowDownwardIcon from '@mui/icons-material/ArrowDownward';
import ArrowUpwardIcon from '@mui/icons-material/ArrowUpward';

function App() {
  const [sort, setSort] = useState<string>('');
  const [bottleView, setBottleView] = useState<boolean>(false);
  const [filter, setFilter] = useState<boolean>(false);

  const toggleView = () => setBottleView(p => !p);
  const toggleFilter = () => setFilter(p => !p);
  const toggleSort = () => setSort(p => {
    if (!p){
      return 'asc';
    }
    if (p === 'asc'){
      return 'desc';
    } else {
      return '';
    }
  })

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
