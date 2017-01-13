-- Table: public."Scope"

-- DROP TABLE public."Scope";

CREATE TABLE public."Scope"
(
  "Id" uuid NOT NULL,
  "Active" boolean NOT NULL,
  "MinDelay" integer,
  "MaxDelay" integer,
  "PhantomError" double precision,
  CONSTRAINT scope_pkey PRIMARY KEY ("Id")
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public."Scope"
  OWNER TO leon;


-- Table: public."User"

-- DROP TABLE public."User";

CREATE TABLE public."User"
(
  "Id" uuid NOT NULL,
  "Name" character varying(100),
  "ScopeId" uuid NOT NULL,
  CONSTRAINT "User_pkey" PRIMARY KEY ("Id")
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public."User"
  OWNER TO leon;

  
-- Table: public."Task"

-- DROP TABLE public."Task";

CREATE TABLE public."Task"
(
  "Id" uuid NOT NULL,
  "Name" character varying(100) NOT NULL,
  "Description" character varying(500) NOT NULL,
  "Workload" integer NOT NULL,
  "Status" integer NOT NULL,
  "ExecutorId" uuid,
  "ScopeId" uuid NOT NULL,
  CONSTRAINT task_pkey PRIMARY KEY ("Id")
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public."Task"
  OWNER TO leon;
