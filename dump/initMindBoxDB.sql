--
-- PostgreSQL database dump
--

-- Dumped from database version 16.1
-- Dumped by pg_dump version 16.1

-- Started on 2024-04-24 16:43:37

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 4 (class 2615 OID 2200)
-- Name: public; Type: SCHEMA; Schema: -; Owner: -
--

CREATE SCHEMA public;


--
-- TOC entry 4854 (class 0 OID 0)
-- Dependencies: 4
-- Name: SCHEMA public; Type: COMMENT; Schema: -; Owner: -
--

COMMENT ON SCHEMA public IS 'standard public schema';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 216 (class 1259 OID 17941)
-- Name: category; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.category (
    id integer NOT NULL,
    name character varying NOT NULL
);


--
-- TOC entry 4855 (class 0 OID 0)
-- Dependencies: 216
-- Name: COLUMN category.id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.category.id IS 'Интендивикатор';


--
-- TOC entry 4856 (class 0 OID 0)
-- Dependencies: 216
-- Name: COLUMN category.name; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.category.name IS 'имя';


--
-- TOC entry 217 (class 1259 OID 17948)
-- Name: categoryproducts; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.categoryproducts (
    id_category integer NOT NULL,
    id_product integer NOT NULL
);


--
-- TOC entry 4857 (class 0 OID 0)
-- Dependencies: 217
-- Name: COLUMN categoryproducts.id_category; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.categoryproducts.id_category IS 'id категории';


--
-- TOC entry 4858 (class 0 OID 0)
-- Dependencies: 217
-- Name: COLUMN categoryproducts.id_product; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.categoryproducts.id_product IS 'id продукта';


--
-- TOC entry 215 (class 1259 OID 17934)
-- Name: products; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.products (
    id integer NOT NULL,
    name character varying NOT NULL
);


--
-- TOC entry 4859 (class 0 OID 0)
-- Dependencies: 215
-- Name: COLUMN products.id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.products.id IS 'Интендфикатор';


--
-- TOC entry 4860 (class 0 OID 0)
-- Dependencies: 215
-- Name: COLUMN products.name; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.products.name IS 'Имя';


--
-- TOC entry 4847 (class 0 OID 17941)
-- Dependencies: 216
-- Data for Name: category; Type: TABLE DATA; Schema: public; Owner: -
--

INSERT INTO public.category VALUES (1, 'бытовые товары');
INSERT INTO public.category VALUES (2, 'прибор для жидкостей');


--
-- TOC entry 4848 (class 0 OID 17948)
-- Dependencies: 217
-- Data for Name: categoryproducts; Type: TABLE DATA; Schema: public; Owner: -
--

INSERT INTO public.categoryproducts VALUES (1, 2);
INSERT INTO public.categoryproducts VALUES (1, 1);
INSERT INTO public.categoryproducts VALUES (2, 2);


--
-- TOC entry 4846 (class 0 OID 17934)
-- Dependencies: 215
-- Data for Name: products; Type: TABLE DATA; Schema: public; Owner: -
--

INSERT INTO public.products VALUES (1, 'духовка');
INSERT INTO public.products VALUES (2, 'чайник');
INSERT INTO public.products VALUES (3, 'плита');


--
-- TOC entry 4698 (class 2606 OID 17947)
-- Name: category category_pk; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.category
    ADD CONSTRAINT category_pk PRIMARY KEY (id);


--
-- TOC entry 4700 (class 2606 OID 17952)
-- Name: categoryproducts categoryproducts_pk; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.categoryproducts
    ADD CONSTRAINT categoryproducts_pk PRIMARY KEY (id_category, id_product);


--
-- TOC entry 4696 (class 2606 OID 17940)
-- Name: products products_pk; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pk PRIMARY KEY (id);


--
-- TOC entry 4701 (class 2606 OID 17953)
-- Name: categoryproducts categoryproducts_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.categoryproducts
    ADD CONSTRAINT categoryproducts_fk FOREIGN KEY (id_category) REFERENCES public.category(id);


--
-- TOC entry 4702 (class 2606 OID 17958)
-- Name: categoryproducts categoryproducts_fk_1; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.categoryproducts
    ADD CONSTRAINT categoryproducts_fk_1 FOREIGN KEY (id_product) REFERENCES public.products(id);


-- Completed on 2024-04-24 16:43:37

--
-- PostgreSQL database dump complete
--

