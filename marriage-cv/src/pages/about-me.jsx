import { useState } from "react";
import Slideshow from "../components/slideshow";
import '../components/about-me.css';
import { Badge } from "react-bootstrap";
import { Container } from "react-bootstrap";
import { Row } from "react-bootstrap";
import { Col } from "react-bootstrap";


function AboutMePage() {
    return (
        <>
            <Row className="justify-content-center mt-3 mb-5">
                <Badge><h1>About Me</h1></Badge>
            </Row>
            <Container fluid>
                <Row id="background-title">
                    <Col>
                        <h1>Background</h1>
                    </Col>
                </Row>
                <Row id="background-info">
                    <Col className="text-start">
                        <p>
                            So... I was born in Bangladesh (yes I'm a freshie) and came to the UK when I was
                            1 years old. I'm an only child, so if you move in with me then you will
                            definitely get some piece and quiet, if that's what you're after. I'm a Software Developer and
                        </p>
                    </Col>
                    <Col className="text-end">
                        <Slideshow />
                    </Col>
                </Row>
            </Container>
            <Container fluid>
                <Row>
                    <Col className="text-end">
                        <h1>Hobbies & Interests</h1>
                    </Col>
                </Row>
                <Row id="background-info">
                    <Col className="text-start">
                        <Slideshow />
                    </Col>
                    <Col className="mt-5">
                        <p>
                            So... I was born in Bangladesh (yes I'm a freshie) and came to the UK when I was
                            1 years old. I'm an only child, so if you move in with me then you will
                            definitely get some piece and quiet, if that's what you're after. I'm a Software Developer and
                        </p>
                    </Col>
                </Row>
            </Container>
        </>
    )
}

export default AboutMePage;