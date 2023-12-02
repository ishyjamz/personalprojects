import { useState } from 'react';
import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import Form from 'react-bootstrap/Form';


export default function ApplyNow() {
    const [show, setShow] = useState(false);
    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    return <>
        <div>
            <h1 className="d-flex justify-content-center">
                Application
            </h1>
            <h5 className="d-flex justify-content-center">
                If you like what you see so far, then why not fill out
                an application to be my wife and see where it takes us
            </h5>
        </div>
        <div className='d-flex justify-content-center'>
            <Button variant="primary" onClick={handleShow}>
                Apply Now
            </Button>

            <Modal show={show} onHide={handleClose} backdrop="static" keyboard="false" size="lg">
                <Modal.Header closeButton>
                    <Modal.Title>Details</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <Form>
                        <div className='d-flex'>
                            <Form.Group className="mb-3 me-3" controlId="exampleForm.ControlInput1">
                                <Form.Label>First Name: </Form.Label>
                                <Form.Control type="text" placeholder="Enter First Name" />
                            </Form.Group>
                            <Form.Group className="mb-3 ms-3" controlId="exampleForm.ControlInput1">
                                <Form.Label>Surname: </Form.Label>
                                <Form.Control type="text" placeholder="Enter Surname" />
                            </Form.Group>
                        </div>
                        <div className='mb-3'>
                            <h5>
                                Preferred Contact Method
                            </h5>
                            <div className='d-flex'>
                            <Form.Check className='me-3' // prettier-ignore
                                type="switch"
                                id="custom-switch"
                                label="Phone"
                            />
                            <Form.Check // prettier-ignore
                                type="switch"
                                id="custom-switch"
                                label="Email"
                            />
                            </div>   
                        </div>
                        <div className='d-flex'>
                        <Form.Group className="mb-3 me-3" controlId="exampleForm.ControlInput1">
                                <Form.Label>Email: </Form.Label>
                                <Form.Control type="email" placeholder="Enter email" />
                            </Form.Group>
                        </div>
                        <div className='d-flex'>
                        <Form.Group className="mb-3 me-3" controlId="exampleForm.ControlInput1">
                                <Form.Label>Phone Number: </Form.Label>
                                <Form.Control type="email" placeholder="Enter mobile number" />
                            </Form.Group>
                        </div>

                        <Form.Group className="mb-3" controlId="exampleForm.ControlTextarea1">
                            <Form.Label>A little bit about yourself: </Form.Label>
                            <p>What you look for in a spouse? Hobbies? Who you are as a person? (max. 400 words)</p>
                            <Form.Control as="textarea" rows={6} />
                            <p>words remaining:</p>
                        </Form.Group>
                    </Form>
                </Modal.Body>
                <Modal.Footer>
                    <Button variant="secondary" onClick={handleClose}>
                        Close
                    </Button>
                    <Button variant="primary" onClick={handleClose}>
                        Apply
                    </Button>
                </Modal.Footer>
            </Modal>
        </div>
    </>
}

