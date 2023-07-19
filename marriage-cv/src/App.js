import Home from "./pages/home";
import AboutMePage from "./pages/about-me";
import { Router, Routes, Route } from "react-router-dom";
import NavBar from "./components/navbar";

export default function App() {
  return (
    <>
    
    <NavBar />

    <Routes>
      <Route path="/home" element={<Home/>} />
      <Route path="/about-me" element={<AboutMePage/>}/>
    </Routes>
    </>
  )
}