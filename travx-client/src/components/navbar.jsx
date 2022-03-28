import './navbar.css';
import maxoLogo from '../images/maxo-logo-red.png'
import { Routes, Route, Link, BrowserRouter as Router } from 'react-router-dom';
import React , { Component } from 'react';

export default class Navbar extends Component{
    constructor() {
        super()
    }
    props = {
        lablel1: "",
        lablel2:"Sign up"
    }
    render() {
        return (
            <nav class="navbar navbar-expand-lg">
                <div class="container">
                    <a class="navbar-brand" href="#"> <img src={maxoLogo} alt="" srcset="" /> Navbar</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <div class="collapse navbar-collapse d-flex justify-content-between" id="navbarNavDropdown">
                        <ul class="navbar-nav">
                            <li class="nav-item">
                                <a class="nav-link active" aria-current="page">Home</a></li>
                    
                            <li class="nav-item dropdown">
                                <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink"
                                    role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                    Dropdown <link rel="stylesheet" href="" /></a>
                                <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                                
                                    <li><a class="dropdown-item" href="#">Action</a></li>
                                    <li><a class="dropdown-item" href="#">Another action</a></li>
                                    <li><a class="dropdown-item" href="#">Something else here</a></li>
                                
                                </ul>
                            </li>
                        </ul>
                        <ul class=" navbar-nav navbar-right ">
                            <li class="nav-item"><a class="nav-link btn btn-danger text-light py-1 px-2" href="">{ this.props.lable1}</a></li>
                            <li class="nav-item"><a class="nav-link nav-link btn ms-3 px-2 py-1 border border-danger" href="">{ this.props.lablel2}</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
        );
    }
}


