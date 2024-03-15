import React from 'react';
import './App.css';
import "bootstrap/dist/css/bootstrap.min.css"
import Header from './header';
import BowlerList from './bowlers/bowlerlist';

function App() {
  return (
    <div className="App">
      <Header title="Welcome to the bowling league"/>
      <BowlerList />
    </div>
  );
}

export default App;
