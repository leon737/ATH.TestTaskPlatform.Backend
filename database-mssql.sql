-- Table: "Scope"

-- DROP TABLE Scope;

CREATE TABLE dbo.Scope
(
  Id uniqueidentifier NOT NULL,
  Active bit NOT NULL,
  MinDelay integer,
  MaxDelay integer,
  PhantomError double precision,
  CONSTRAINT scope_pkey PRIMARY KEY (Id)
);

-- Table: User

-- DROP TABLE [User];

CREATE TABLE dbo.[User]
(
  Id uniqueidentifier NOT NULL,
  Name character varying(100),
  ScopeId uniqueidentifier NOT NULL,
  CONSTRAINT User_pkey PRIMARY KEY (Id)
);
  
-- Table: Task

-- DROP TABLE Task;

CREATE TABLE dbo.Task
(
  Id uniqueidentifier NOT NULL,
  Name character varying(100) NOT NULL,
  Description character varying(500) NOT NULL,
  Workload integer NOT NULL,
  Status integer NOT NULL,
  ExecutorId uniqueidentifier,
  ScopeId uniqueidentifier NOT NULL,
  CONSTRAINT task_pkey PRIMARY KEY (Id)
);