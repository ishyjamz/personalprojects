import { useState } from "react";
import Slideshow from "../components/slideshow";
import '../components/about-me.css';
import { Badge } from "react-bootstrap";
import Hobbies from "../components/hobbies";

function AboutMePage(){
    return (
        <>
        <div className="d-flex justify-content-center mt-3 mb-3">
            <Badge><h1>About Me</h1></Badge>
        </div>
        <div className="d-flex justify-content-center mt-3 mb-5">
        <Slideshow />
        </div>
        <div className="d-flex justify-content-center mt-3 mb-5">
            <Hobbies/>
        </div>

        </>
    )
}

export default AboutMePage;