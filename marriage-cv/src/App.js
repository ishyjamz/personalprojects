import Home from "./pages/home";
import AboutMePage from "./pages/about-me";
import { Router, Routes, Route } from "react-router-dom";
import NavBar from "./components/navbar";
import EducationPage from "./pages/education";
import FunQuestionsPage from "./pages/fun-questions";
import './App.css';
import QuizPage from "./pages/quiz";
import ApplyNow from "./pages/apply-now";

export default function App() {
  return (
    <>
    
    <NavBar />

    <Routes>
      <Route path="/" element={<Home/>} />
      <Route path="/about-me" element={<AboutMePage/>}/>
      <Route path="/education" element={<EducationPage/>}/>
      <Route path='/fun-questions' element={<FunQuestionsPage/>}/>
      <Route path='/quiz' element={<QuizPage/>}></Route>
      <Route path='/apply' element={<ApplyNow/>}></Route>
    </Routes>
    </>
  )
}