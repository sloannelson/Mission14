import React from "react";
import logo from "../JoelHiltonHeadshot.jpg";
import "./App.css";
import Header from "../Header";
import MovieList from "../movie/MovieList";

function App() {
  return (
    <div className="App">
      <Header slogan="Joel Hilton Film Collection!" />
      <MovieList />
    </div>
  );
}

export default App;
