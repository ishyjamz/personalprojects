import { Accordion } from "react-bootstrap"
import Grad from '../images/grad.jpg'

function EducationPage() {
    return (
        <>
            <div className="d-flex justify-content-center mt-3">
                <h1>Education</h1>
            </div>
            <div className="d-flex justify-content-center mt-3">
                <Accordion style={{ width: '500px' }} defaultActiveKey={['0']} alwaysOpen>
                    <Accordion.Item eventKey="0">
                        <Accordion.Header>Career & Ambitions</Accordion.Header>
                        <Accordion.Body>
                            My hobbies unironically are reading quran, coding dumb things like this website, playing sport, watching sport,
                            islamic studies, gaming, anime etc etc
                        </Accordion.Body>
                    </Accordion.Item>
                </Accordion>
            </div>
            <div className="d-flex justify-content-center mt-3">
                <div className="me-3">
                    <Accordion style={{ width: '500px' }} defaultActiveKey={['0']} alwaysOpen>
                        <Accordion.Item eventKey="0">
                            <Accordion.Header>Higher Education</Accordion.Header>
                            <Accordion.Body>
                                My hobbies unironically are reading quran, coding dumb things like this website, playing sport, watching sport,
                                islamic studies, gaming, anime etc etc
                            </Accordion.Body>
                        </Accordion.Item>
                    </Accordion>
                </div>
                <div className="ms-3">
                    <Accordion style={{ width: '500px' }} defaultActiveKey={['0']} alwaysOpen>
                        <Accordion.Item eventKey="0">
                            <Accordion.Header>GCSEs and A Levels</Accordion.Header>
                            <Accordion.Body>
                                My hobbies unironically are reading quran, coding dumb things like this website, playing sport, watching sport,
                                islamic studies, gaming, anime etc etc
                            </Accordion.Body>
                        </Accordion.Item>
                    </Accordion>
                </div>
            </div>
        </>
    )
}

export default EducationPage